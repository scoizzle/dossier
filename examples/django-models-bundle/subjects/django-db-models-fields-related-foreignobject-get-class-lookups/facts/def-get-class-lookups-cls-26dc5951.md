# Fact 26dc5951

Store id: eb524495-b3f0-416e-b4df-11335affc9b2

## Text

```text
def get_class_lookups(cls)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class_method`, `decorator:classmethod`, `decorator:functools.cache`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:44.3611310+00:00`

## Data

```json
{
  "end_line": 937,
  "entity_kind": "class_method",
  "parent": "ForeignObject",
  "start_line": 931,
  "symbol": "ForeignObject.get_class_lookups"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":931,"selector":"L931-L937","symbol":"ForeignObject.get_class_lookups"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.get_class_lookups](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 937,
    "entity_kind": "class_method",
    "parent": "ForeignObject",
    "start_line": 931,
    "symbol": "ForeignObject.get_class_lookups"
  },
  "id": "eb524495-b3f0-416e-b4df-11335affc9b2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3611310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 931,
        "selector": "L931-L937",
        "symbol": "ForeignObject.get_class_lookups"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "3bf9ad8b-c608-41a8-ac11-12be305a7141",
  "subject_name": "django/db/models/fields/related::ForeignObject.get_class_lookups",
  "tags": [
    "entity:class_method",
    "decorator:classmethod",
    "decorator:functools.cache"
  ],
  "text": "def get_class_lookups(cls)"
}
```
