# Fact 8e16cf5d

Store id: 5929ba5f-468c-4a28-b465-24a183e92144

## Text

```text
class Concat(Func)
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
- posted_at: `2026-11-09T23:44:54.0748280+00:00`

## Data

```json
{
  "end_line": 151,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 125,
  "symbol": "Concat"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":125,"selector":"L125-L151","symbol":"Concat"}`

## Items

```json
[
  {
    "text": "Concatenate text fields together. Backends that result in an entire null expression when any arguments are null will wrap each argument in coalesce functions to ensure a non-null result.",
    "locator": {
      "line": 126
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/functions/text::Concat](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 151,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 125,
    "symbol": "Concat"
  },
  "id": "5929ba5f-468c-4a28-b465-24a183e92144",
  "items": [
    {
      "locator": {
        "line": 126
      },
      "text": "Concatenate text fields together. Backends that result in an entire null expression when any arguments are null will wrap each argument in coalesce functions to ensure a non-null result."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.0748280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 125,
        "selector": "L125-L151",
        "symbol": "Concat"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "a2f1afa2-4bdb-4ae3-9729-b4a46e828972",
  "subject_name": "django/db/models/functions/text::Concat",
  "tags": [
    "entity:class"
  ],
  "text": "class Concat(Func)"
}
```
