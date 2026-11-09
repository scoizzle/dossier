# Fact 83ad4936

Store id: 7744f111-d46e-45d2-a185-20fc935287c2

## Text

```text
def __eq__(self, other)
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
- posted_at: `2026-11-09T22:39:45.3362730+00:00`

## Data

```json
{
  "end_line": 155,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 152,
  "symbol": "ForeignObjectRel.__eq__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":152,"selector":"L152-L155","symbol":"ForeignObjectRel.__eq__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.__eq__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 155,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 152,
    "symbol": "ForeignObjectRel.__eq__"
  },
  "id": "7744f111-d46e-45d2-a185-20fc935287c2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.3362730+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 152,
        "selector": "L152-L155",
        "symbol": "ForeignObjectRel.__eq__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "936354bd-5b7d-49ab-9bd1-82b9d1109595",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```
