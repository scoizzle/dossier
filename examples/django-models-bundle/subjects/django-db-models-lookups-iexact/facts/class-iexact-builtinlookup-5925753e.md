# Fact 5925753e

Store id: d53f1d58-f4c9-4dd2-a5d1-2b560babbd7e

## Text

```text
class IExact(BuiltinLookup)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:Field.register_lookup`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:48.1079850+00:00`

## Data

```json
{
  "end_line": 422,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 413,
  "symbol": "IExact"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":413,"selector":"L413-L422","symbol":"IExact"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::IExact](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 422,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 413,
    "symbol": "IExact"
  },
  "id": "d53f1d58-f4c9-4dd2-a5d1-2b560babbd7e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.1079850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 413,
        "selector": "L413-L422",
        "symbol": "IExact"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "24dc7bb5-afdf-46a4-9221-ef5621be3624",
  "subject_name": "django/db/models/lookups::IExact",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class IExact(BuiltinLookup)"
}
```
