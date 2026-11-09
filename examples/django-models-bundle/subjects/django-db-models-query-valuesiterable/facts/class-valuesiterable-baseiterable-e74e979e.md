# Fact e74e979e

Store id: ba8811ae-d566-4043-890d-a6bca56df03b

## Text

```text
class ValuesIterable(BaseIterable)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:04.2610500+00:00`

## Data

```json
{
  "end_line": 284,
  "entity_kind": "class",
  "parent": "query",
  "start_line": 261,
  "symbol": "ValuesIterable"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":261,"selector":"L261-L284","symbol":"ValuesIterable"}`

## Items

```json
[
  {
    "text": "Iterable returned by QuerySet.values() that yields a dict for each row.",
    "locator": {
      "line": 262
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::ValuesIterable](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 284,
    "entity_kind": "class",
    "parent": "query",
    "start_line": 261,
    "symbol": "ValuesIterable"
  },
  "id": "ba8811ae-d566-4043-890d-a6bca56df03b",
  "items": [
    {
      "locator": {
        "line": 262
      },
      "text": "Iterable returned by QuerySet.values() that yields a dict for each row."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.2610500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 261,
        "selector": "L261-L284",
        "symbol": "ValuesIterable"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "1610d974-80c6-472f-a10b-4c36ea0093ef",
  "subject_name": "django/db/models/query::ValuesIterable",
  "tags": [
    "entity:class"
  ],
  "text": "class ValuesIterable(BaseIterable)"
}
```
