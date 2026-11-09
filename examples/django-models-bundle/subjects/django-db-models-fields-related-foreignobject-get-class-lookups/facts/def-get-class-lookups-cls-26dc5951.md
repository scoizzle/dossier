# Fact 26dc5951

Store id: 66066587-df19-4734-bd7f-f133804c5037

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
- posted_at: `2026-11-09T23:31:58.7321780+00:00`

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
  "id": "66066587-df19-4734-bd7f-f133804c5037",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.7321780+00:00"
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
  "subject_id": "5823577b-1f38-4afd-a5ce-af8c3825d850",
  "subject_name": "django/db/models/fields/related::ForeignObject.get_class_lookups",
  "tags": [
    "entity:class_method",
    "decorator:classmethod",
    "decorator:functools.cache"
  ],
  "text": "def get_class_lookups(cls)"
}
```
