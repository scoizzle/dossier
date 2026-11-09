# Fact ee83963e

Store id: d9a97960-8e96-41f8-a47e-b5576ca3351d

## Text

```text
def get_bilateral_transforms(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:54.9188080+00:00`

## Data

```json
{
  "end_line": 231,
  "entity_kind": "method",
  "parent": "Transform",
  "start_line": 224,
  "symbol": "Transform.get_bilateral_transforms"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":224,"selector":"L224-L231","symbol":"Transform.get_bilateral_transforms"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Transform.get_bilateral_transforms](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 231,
    "entity_kind": "method",
    "parent": "Transform",
    "start_line": 224,
    "symbol": "Transform.get_bilateral_transforms"
  },
  "id": "d9a97960-8e96-41f8-a47e-b5576ca3351d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.9188080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 224,
        "selector": "L224-L231",
        "symbol": "Transform.get_bilateral_transforms"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "5c861a3b-3f66-4375-b247-ad3a66920df0",
  "subject_name": "django/db/models/lookups::Transform.get_bilateral_transforms",
  "tags": [
    "entity:method"
  ],
  "text": "def get_bilateral_transforms(self)"
}
```
