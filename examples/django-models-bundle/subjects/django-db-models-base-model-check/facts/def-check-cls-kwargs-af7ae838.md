# Fact af7ae838

Store id: b963e166-c6a6-4df5-a78d-5b68b1fd5d7d

## Text

```text
def check(cls, **kwargs)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class_method`, `decorator:classmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:48.5460850+00:00`

## Data

```json
{
  "end_line": 1811,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 1775,
  "symbol": "Model.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1775,"selector":"L1775-L1811","symbol":"Model.check"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1811,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 1775,
    "symbol": "Model.check"
  },
  "id": "b963e166-c6a6-4df5-a78d-5b68b1fd5d7d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5460850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1775,
        "selector": "L1775-L1811",
        "symbol": "Model.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "59d9602b-afe1-4085-9a79-4c3bb271e50c",
  "subject_name": "django/db/models/base::Model.check",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def check(cls, **kwargs)"
}
```
