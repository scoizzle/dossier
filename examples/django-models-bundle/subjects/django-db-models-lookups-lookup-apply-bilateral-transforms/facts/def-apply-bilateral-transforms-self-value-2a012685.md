# Fact 2a012685

Store id: 29d61cc4-298e-40c0-92f8-d3eb27ae9a94

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
- posted_at: `2026-11-09T22:39:47.9746560+00:00`

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
  "id": "29d61cc4-298e-40c0-92f8-d3eb27ae9a94",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.9746560+00:00"
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
  "subject_id": "8b9cd567-56e0-4d59-b48f-c7f021ab787e",
  "subject_name": "django/db/models/lookups::Lookup.apply_bilateral_transforms",
  "tags": [
    "entity:method"
  ],
  "text": "def apply_bilateral_transforms(self, value)"
}
```
