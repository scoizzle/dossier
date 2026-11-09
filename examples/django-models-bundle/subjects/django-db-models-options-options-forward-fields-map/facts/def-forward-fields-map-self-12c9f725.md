# Fact 12c9f725

Store id: 4a235f59-d6c8-4be5-8a74-5ad158b391d9

## Text

```text
def _forward_fields_map(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:03.9958250+00:00`

## Data

```json
{
  "end_line": 653,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 640,
  "symbol": "Options._forward_fields_map"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":640,"selector":"L640-L653","symbol":"Options._forward_fields_map"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options._forward_fields_map](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 653,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 640,
    "symbol": "Options._forward_fields_map"
  },
  "id": "4a235f59-d6c8-4be5-8a74-5ad158b391d9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.9958250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 640,
        "selector": "L640-L653",
        "symbol": "Options._forward_fields_map"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "68b8c91e-47f7-4d5f-bd89-4c6a6e858ffc",
  "subject_name": "django/db/models/options::Options._forward_fields_map",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def _forward_fields_map(self)"
}
```
