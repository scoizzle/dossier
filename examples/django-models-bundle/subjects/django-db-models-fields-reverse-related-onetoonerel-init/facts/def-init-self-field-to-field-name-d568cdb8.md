# Fact d568cdb8

Store id: 32bf69c3-7242-4cef-8f84-ec1c4f041b76

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
- posted_at: `2026-11-09T23:32:00.3437860+00:00`

## Data

```json
{
  "end_line": 343,
  "entity_kind": "method",
  "parent": "OneToOneRel",
  "start_line": 321,
  "symbol": "OneToOneRel.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":321,"selector":"L321-L343","symbol":"OneToOneRel.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::OneToOneRel.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 343,
    "entity_kind": "method",
    "parent": "OneToOneRel",
    "start_line": 321,
    "symbol": "OneToOneRel.__init__"
  },
  "id": "32bf69c3-7242-4cef-8f84-ec1c4f041b76",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.3437860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 321,
        "selector": "L321-L343",
        "symbol": "OneToOneRel.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "cb28bf89-1ca3-4eaa-bfbf-14f85893ee3c",
  "subject_name": "django/db/models/fields/reverse_related::OneToOneRel.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, field, to, field_name, related_name=None, related_query_name=None, limit_choices_to=None, parent_link=False, on_delete=None, )"
}
```
