# Fact ee83963e

Store id: c9048326-969a-4968-bb28-1c5e1c4b8b8e

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
- posted_at: `2026-11-09T23:32:03.2062780+00:00`

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
  "id": "c9048326-969a-4968-bb28-1c5e1c4b8b8e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.2062780+00:00"
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
  "subject_id": "0ed1164d-1772-4fd3-a581-bdede26d6597",
  "subject_name": "django/db/models/lookups::Transform.get_bilateral_transforms",
  "tags": [
    "entity:method"
  ],
  "text": "def get_bilateral_transforms(self)"
}
```
