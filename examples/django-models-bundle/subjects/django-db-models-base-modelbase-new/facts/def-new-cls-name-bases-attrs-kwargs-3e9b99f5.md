# Fact 3e9b99f5

Store id: 7466cfd0-5923-4898-b21f-b3b97a276d6e

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
- posted_at: `2026-11-09T22:39:40.3253260+00:00`

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
  "id": "7466cfd0-5923-4898-b21f-b3b97a276d6e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3253260+00:00"
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
  "subject_id": "0721c531-5a2b-41fa-ad49-a63aab87f05c",
  "subject_name": "django/db/models/base::ModelBase.__new__",
  "tags": [
    "entity:method"
  ],
  "text": "def __new__(cls, name, bases, attrs, **kwargs)"
}
```
