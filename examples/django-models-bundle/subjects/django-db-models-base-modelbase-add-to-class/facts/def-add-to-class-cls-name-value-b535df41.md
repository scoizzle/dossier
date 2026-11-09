# Fact b535df41

Store id: 107bc751-38fd-4d60-a024-a31a3639f7b3

## Text

```text
def add_to_class(cls, name, value)
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
- posted_at: `2026-11-09T22:39:40.3258290+00:00`

## Data

```json
{
  "end_line": 396,
  "entity_kind": "method",
  "parent": "ModelBase",
  "start_line": 392,
  "symbol": "ModelBase.add_to_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":392,"selector":"L392-L396","symbol":"ModelBase.add_to_class"}`

## Referenced by

None.

## Subject

[django/db/models/base::ModelBase.add_to_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 396,
    "entity_kind": "method",
    "parent": "ModelBase",
    "start_line": 392,
    "symbol": "ModelBase.add_to_class"
  },
  "id": "107bc751-38fd-4d60-a024-a31a3639f7b3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3258290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 392,
        "selector": "L392-L396",
        "symbol": "ModelBase.add_to_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "da7952cc-2286-4c16-9270-6ca701ce5ca4",
  "subject_name": "django/db/models/base::ModelBase.add_to_class",
  "tags": [
    "entity:method"
  ],
  "text": "def add_to_class(cls, name, value)"
}
```
