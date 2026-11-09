# Fact 7965ca58

Store id: a03d994a-74ba-468c-9e0d-8f495acd42fb

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
- posted_at: `2026-11-09T22:39:48.8836740+00:00`

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
  "id": "a03d994a-74ba-468c-9e0d-8f495acd42fb",
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
    "posted_at": "2026-11-09T22:39:48.8836740+00:00"
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
  "subject_id": "c7a44291-e159-4a80-aa32-6f754837c705",
  "subject_name": "django/db/models/options::Options.get_ancestor_link",
  "tags": [
    "entity:method"
  ],
  "text": "def get_ancestor_link(self, ancestor)"
}
```
