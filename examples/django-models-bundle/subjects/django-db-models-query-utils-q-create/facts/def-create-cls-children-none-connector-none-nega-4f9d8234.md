# Fact 4f9d8234

Store id: 445e0fa9-b23e-4307-a356-5d40e1056957

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
- posted_at: `2026-11-09T23:32:05.0353580+00:00`

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
  "id": "445e0fa9-b23e-4307-a356-5d40e1056957",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.0353580+00:00"
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
  "subject_id": "5f23357c-e526-4f3c-a5a0-ab83a1aea4d2",
  "subject_name": "django/db/models/query_utils::Q.create",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def create(cls, children=None, connector=None, negated=False)"
}
```
