# Fact 7965ca58

Store id: 026880a1-25db-442c-b92e-7b252706d0ca

## Text

```text
def get_ancestor_link(self, ancestor)
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
- posted_at: `2026-11-09T23:44:55.5635810+00:00`

## Data

```json
{
  "end_line": 752,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 734,
  "symbol": "Options.get_ancestor_link"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":734,"selector":"L734-L752","symbol":"Options.get_ancestor_link"}`

## Items

```json
[
  {
    "text": "Return the field on the current model which points to the given \"ancestor\". This is possible an indirect link (a pointer to a parent model, which points, eventually, to the ancestor). Used when constructing table joins for model inheritance.",
    "locator": {
      "line": 735
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::Options.get_ancestor_link](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 752,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 734,
    "symbol": "Options.get_ancestor_link"
  },
  "id": "026880a1-25db-442c-b92e-7b252706d0ca",
  "items": [
    {
      "locator": {
        "line": 735
      },
      "text": "Return the field on the current model which points to the given \"ancestor\". This is possible an indirect link (a pointer to a parent model, which points, eventually, to the ancestor). Used when constructing table joins for model inheritance."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.5635810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 734,
        "selector": "L734-L752",
        "symbol": "Options.get_ancestor_link"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "2981e803-b766-489b-9d9f-23bb8f246213",
  "subject_name": "django/db/models/options::Options.get_ancestor_link",
  "tags": [
    "entity:method"
  ],
  "text": "def get_ancestor_link(self, ancestor)"
}
```
