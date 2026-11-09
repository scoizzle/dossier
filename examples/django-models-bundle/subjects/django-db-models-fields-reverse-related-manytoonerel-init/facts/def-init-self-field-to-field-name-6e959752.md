# Fact 6e959752

Store id: 7339e55c-f745-45f3-9689-bcd79ce76d1c

## Text

```text
def __init__( self, field, to, field_name, related_name=None, related_query_name=None, limit_choices_to=None, parent_link=False, on_delete=None, )
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
- posted_at: `2026-11-09T23:32:00.3223230+00:00`

## Data

```json
{
  "end_line": 287,
  "entity_kind": "method",
  "parent": "ManyToOneRel",
  "start_line": 266,
  "symbol": "ManyToOneRel.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":266,"selector":"L266-L287","symbol":"ManyToOneRel.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ManyToOneRel.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 287,
    "entity_kind": "method",
    "parent": "ManyToOneRel",
    "start_line": 266,
    "symbol": "ManyToOneRel.__init__"
  },
  "id": "7339e55c-f745-45f3-9689-bcd79ce76d1c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.3223230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 266,
        "selector": "L266-L287",
        "symbol": "ManyToOneRel.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "0ab53ed3-e57a-4f72-ad0e-805c7a387a49",
  "subject_name": "django/db/models/fields/reverse_related::ManyToOneRel.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, field, to, field_name, related_name=None, related_query_name=None, limit_choices_to=None, parent_link=False, on_delete=None, )"
}
```
