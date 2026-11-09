# Fact 99cd84dc

Store id: 30071759-40e5-4d75-a704-05f6beebc347

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T22:39:41.6122160+00:00`

## Data

```json
{
  "end_line": 1305,
  "entity_kind": "method",
  "parent": "Star",
  "start_line": 1304,
  "symbol": "Star.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1304,"selector":"L1304-L1305","symbol":"Star.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Star.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1305,
    "entity_kind": "method",
    "parent": "Star",
    "start_line": 1304,
    "symbol": "Star.__repr__"
  },
  "id": "30071759-40e5-4d75-a704-05f6beebc347",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6122160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1304,
        "selector": "L1304-L1305",
        "symbol": "Star.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "8582640f-bbba-4bcc-8103-5c16a889e5b7",
  "subject_name": "django/db/models/expressions::Star.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
