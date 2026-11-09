# Fact 598f7878

Store id: ff25ffc1-c731-478c-a9fb-54cf40ab48a5

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
- posted_at: `2026-11-09T22:39:45.3276140+00:00`

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
  "id": "ff25ffc1-c731-478c-a9fb-54cf40ab48a5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.3276140+00:00"
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
  "subject_id": "f153aec5-f3a7-420d-84af-36ac112fc195",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
