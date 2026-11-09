# Fact 722eabd3

Store id: 398684dd-1acb-4a96-956e-528edb0307b4

## Text

```text
def __len__(self)
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
- posted_at: `2026-11-09T23:44:52.6787270+00:00`

## Data

```json
{
  "end_line": 33,
  "entity_kind": "method",
  "parent": "Tuple",
  "start_line": 32,
  "symbol": "Tuple.__len__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":32,"selector":"L32-L33","symbol":"Tuple.__len__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::Tuple.__len__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 33,
    "entity_kind": "method",
    "parent": "Tuple",
    "start_line": 32,
    "symbol": "Tuple.__len__"
  },
  "id": "398684dd-1acb-4a96-956e-528edb0307b4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.6787270+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 32,
        "selector": "L32-L33",
        "symbol": "Tuple.__len__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "b626f09d-abef-4119-a9a3-e26a00d08eab",
  "subject_name": "django/db/models/fields/tuple_lookups::Tuple.__len__",
  "tags": [
    "entity:method"
  ],
  "text": "def __len__(self)"
}
```
