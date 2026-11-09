# Fact e74e979e

Store id: 4245ecf5-13b8-4c16-b241-3500658161dd

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
- posted_at: `2026-11-09T23:44:55.7916520+00:00`

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
  "id": "4245ecf5-13b8-4c16-b241-3500658161dd",
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
    "posted_at": "2026-11-09T23:44:55.7916520+00:00"
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
  "subject_id": "11a12ddf-77a4-4bcc-adf5-9e0e6e8a91ac",
  "subject_name": "django/db/models/query::ValuesIterable",
  "tags": [
    "entity:class"
  ],
  "text": "class ValuesIterable(BaseIterable)"
}
```
