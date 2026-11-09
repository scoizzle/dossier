# Fact 6f1fb8ca

Store id: 1d5a2d79-379c-475d-b0ba-565f56ecc7b0

## Text

```text
def path_infos(self)
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
- posted_at: `2026-11-09T22:39:45.3621720+00:00`

## Data

```json
{
  "end_line": 240,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 238,
  "symbol": "ForeignObjectRel.path_infos"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":238,"selector":"L238-L240","symbol":"ForeignObjectRel.path_infos"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.path_infos](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 240,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 238,
    "symbol": "ForeignObjectRel.path_infos"
  },
  "id": "1d5a2d79-379c-475d-b0ba-565f56ecc7b0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.3621720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 238,
        "selector": "L238-L240",
        "symbol": "ForeignObjectRel.path_infos"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "466909c0-d2db-4551-ad7d-2bfaf0847f70",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.path_infos",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def path_infos(self)"
}
```
