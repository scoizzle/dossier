# Fact 5925753e

Store id: ca78d3b2-724f-4deb-97d2-5e9edb40e35d

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
- posted_at: `2026-11-09T23:44:54.9594880+00:00`

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
  "id": "ca78d3b2-724f-4deb-97d2-5e9edb40e35d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.9594880+00:00"
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
  "subject_id": "dce440e8-71c4-47fe-8626-35da8ba00438",
  "subject_name": "django/db/models/lookups::IExact",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class IExact(BuiltinLookup)"
}
```
