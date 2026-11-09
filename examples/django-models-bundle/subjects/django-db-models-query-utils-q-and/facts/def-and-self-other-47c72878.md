# Fact 47c72878

Store id: a1be460a-9a9e-460a-a360-f6aab46bdcbd

## Text

```text
def __and__(self, other)
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
- posted_at: `2026-11-09T22:39:50.0658770+00:00`

## Data

```json
{
  "end_line": 91,
  "entity_kind": "method",
  "parent": "Q",
  "start_line": 90,
  "symbol": "Q.__and__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":90,"selector":"L90-L91","symbol":"Q.__and__"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q.__and__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 91,
    "entity_kind": "method",
    "parent": "Q",
    "start_line": 90,
    "symbol": "Q.__and__"
  },
  "id": "a1be460a-9a9e-460a-a360-f6aab46bdcbd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.0658770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 90,
        "selector": "L90-L91",
        "symbol": "Q.__and__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "56bfa90a-f119-456d-89f8-103bb09ad1fc",
  "subject_name": "django/db/models/query_utils::Q.__and__",
  "tags": [
    "entity:method"
  ],
  "text": "def __and__(self, other)"
}
```
