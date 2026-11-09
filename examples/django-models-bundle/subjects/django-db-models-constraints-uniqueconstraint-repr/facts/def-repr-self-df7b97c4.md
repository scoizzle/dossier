# Fact df7b97c4

Store id: fafb0879-e006-477a-8f28-fd93a15466e0

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
- posted_at: `2026-11-09T22:39:40.7286230+00:00`

## Data

```json
{
  "end_line": 544,
  "entity_kind": "method",
  "parent": "UniqueConstraint",
  "start_line": 518,
  "symbol": "UniqueConstraint.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":518,"selector":"L518-L544","symbol":"UniqueConstraint.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::UniqueConstraint.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 544,
    "entity_kind": "method",
    "parent": "UniqueConstraint",
    "start_line": 518,
    "symbol": "UniqueConstraint.__repr__"
  },
  "id": "fafb0879-e006-477a-8f28-fd93a15466e0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.7286230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 518,
        "selector": "L518-L544",
        "symbol": "UniqueConstraint.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "d749063f-6561-492f-bcef-5be5988d6e6a",
  "subject_name": "django/db/models/constraints::UniqueConstraint.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
