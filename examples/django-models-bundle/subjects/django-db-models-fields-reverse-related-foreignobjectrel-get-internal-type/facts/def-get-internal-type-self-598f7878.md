# Fact 598f7878

Store id: 9d78635d-29b4-4b6a-88bc-4df17f9d92f5

## Text

```text
def get_internal_type(self)
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
- posted_at: `2026-11-09T23:32:00.2654390+00:00`

## Data

```json
{
  "end_line": 125,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 124,
  "symbol": "ForeignObjectRel.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":124,"selector":"L124-L125","symbol":"ForeignObjectRel.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 125,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 124,
    "symbol": "ForeignObjectRel.get_internal_type"
  },
  "id": "9d78635d-29b4-4b6a-88bc-4df17f9d92f5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.2654390+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 124,
        "selector": "L124-L125",
        "symbol": "ForeignObjectRel.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "29a05cbc-c8f8-4919-b507-d12cba020dd6",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
