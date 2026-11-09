# Fact 4f9d8234

Store id: 3d6e02ce-d479-4c6b-b0b8-0dbc48398903

## Text

```text
def create(cls, children=None, connector=None, negated=False)
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
- posted_at: `2026-11-09T23:44:56.5152990+00:00`

## Data

```json
{
  "end_line": 66,
  "entity_kind": "class_method",
  "parent": "Q",
  "start_line": 63,
  "symbol": "Q.create"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":63,"selector":"L63-L66","symbol":"Q.create"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q.create](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 66,
    "entity_kind": "class_method",
    "parent": "Q",
    "start_line": 63,
    "symbol": "Q.create"
  },
  "id": "3d6e02ce-d479-4c6b-b0b8-0dbc48398903",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.5152990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 63,
        "selector": "L63-L66",
        "symbol": "Q.create"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "cae5d03e-45d7-4226-9937-354a32c18941",
  "subject_name": "django/db/models/query_utils::Q.create",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def create(cls, children=None, connector=None, negated=False)"
}
```
