# Fact e0d68d0f

Store id: 85e983d6-ed3c-413b-a0c7-14a0dc5b1763

## Text

```text
def _identity(cls, value)
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
- posted_at: `2026-11-09T23:31:55.7996500+00:00`

## Data

```json
{
  "end_line": 538,
  "entity_kind": "class_method",
  "parent": "Expression",
  "start_line": 528,
  "symbol": "Expression._identity"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":528,"selector":"L528-L538","symbol":"Expression._identity"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Expression._identity](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 538,
    "entity_kind": "class_method",
    "parent": "Expression",
    "start_line": 528,
    "symbol": "Expression._identity"
  },
  "id": "85e983d6-ed3c-413b-a0c7-14a0dc5b1763",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7996500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 528,
        "selector": "L528-L538",
        "symbol": "Expression._identity"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "a6155c6b-0859-422a-9bbc-e0bae8a97fbf",
  "subject_name": "django/db/models/expressions::Expression._identity",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _identity(cls, value)"
}
```
