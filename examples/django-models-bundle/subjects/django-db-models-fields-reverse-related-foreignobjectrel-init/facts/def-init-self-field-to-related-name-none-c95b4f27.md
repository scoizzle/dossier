# Fact c95b4f27

Store id: b2e0e102-8f23-4a5f-96a3-6750e55269ce

## Text

```text
def __init__( self, field, to, related_name=None, related_query_name=None, limit_choices_to=None, parent_link=False, on_delete=None, )
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
- posted_at: `2026-11-09T22:39:45.2842230+00:00`

## Data

```json
{
  "end_line": 58,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 39,
  "symbol": "ForeignObjectRel.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":39,"selector":"L39-L58","symbol":"ForeignObjectRel.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 58,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 39,
    "symbol": "ForeignObjectRel.__init__"
  },
  "id": "b2e0e102-8f23-4a5f-96a3-6750e55269ce",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.2842230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 39,
        "selector": "L39-L58",
        "symbol": "ForeignObjectRel.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "3430f4c6-624e-4caf-8f6c-706659a54312",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, field, to, related_name=None, related_query_name=None, limit_choices_to=None, parent_link=False, on_delete=None, )"
}
```
