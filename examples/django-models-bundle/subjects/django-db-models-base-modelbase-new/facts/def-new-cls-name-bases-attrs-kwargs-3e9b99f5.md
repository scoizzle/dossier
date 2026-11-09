# Fact 3e9b99f5

Store id: c0c27858-eeae-42c9-a647-9e9b06ece912

## Text

```text
def __new__(cls, name, bases, attrs, **kwargs)
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
- posted_at: `2026-11-09T23:44:48.5202010+00:00`

## Data

```json
{
  "end_line": 390,
  "entity_kind": "method",
  "parent": "ModelBase",
  "start_line": 98,
  "symbol": "ModelBase.__new__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":98,"selector":"L98-L390","symbol":"ModelBase.__new__"}`

## Referenced by

None.

## Subject

[django/db/models/base::ModelBase.__new__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 390,
    "entity_kind": "method",
    "parent": "ModelBase",
    "start_line": 98,
    "symbol": "ModelBase.__new__"
  },
  "id": "c0c27858-eeae-42c9-a647-9e9b06ece912",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5202010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 98,
        "selector": "L98-L390",
        "symbol": "ModelBase.__new__"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "1d90e620-97d0-42b4-aa50-71e36f829d8f",
  "subject_name": "django/db/models/base::ModelBase.__new__",
  "tags": [
    "entity:method"
  ],
  "text": "def __new__(cls, name, bases, attrs, **kwargs)"
}
```
