# Fact c95b4f27

Store id: 1037faf6-8a61-4ae4-9a95-e99a08844fdb

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
- posted_at: `2026-11-09T23:44:52.4214450+00:00`

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
  "id": "1037faf6-8a61-4ae4-9a95-e99a08844fdb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.4214450+00:00"
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
  "subject_id": "ccdebfce-f14d-45d0-ba1d-e279884aae4a",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, field, to, related_name=None, related_query_name=None, limit_choices_to=None, parent_link=False, on_delete=None, )"
}
```
