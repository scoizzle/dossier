# Fact 2a012685

Store id: 903df0df-5bb4-494f-a944-fdc082de0f46

## Text

```text
def apply_bilateral_transforms(self, value)
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
- posted_at: `2026-11-09T23:44:54.8474930+00:00`

## Data

```json
{
  "end_line": 56,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 53,
  "symbol": "Lookup.apply_bilateral_transforms"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":53,"selector":"L53-L56","symbol":"Lookup.apply_bilateral_transforms"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.apply_bilateral_transforms](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 56,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 53,
    "symbol": "Lookup.apply_bilateral_transforms"
  },
  "id": "903df0df-5bb4-494f-a944-fdc082de0f46",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.8474930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 53,
        "selector": "L53-L56",
        "symbol": "Lookup.apply_bilateral_transforms"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "1e7f2509-5cb9-43b5-89d2-b5e6d03ec6c1",
  "subject_name": "django/db/models/lookups::Lookup.apply_bilateral_transforms",
  "tags": [
    "entity:method"
  ],
  "text": "def apply_bilateral_transforms(self, value)"
}
```
