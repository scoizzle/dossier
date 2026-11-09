# Fact 8e76e1aa

Store id: e65b98fe-8a66-4679-8275-6eb8eaac5dad

## Text

```text
def contains_expressions(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:54.2248360+00:00`

## Data

```json
{
  "end_line": 342,
  "entity_kind": "method",
  "parent": "UniqueConstraint",
  "start_line": 340,
  "symbol": "UniqueConstraint.contains_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":340,"selector":"L340-L342","symbol":"UniqueConstraint.contains_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::UniqueConstraint.contains_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 342,
    "entity_kind": "method",
    "parent": "UniqueConstraint",
    "start_line": 340,
    "symbol": "UniqueConstraint.contains_expressions"
  },
  "id": "e65b98fe-8a66-4679-8275-6eb8eaac5dad",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.2248360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 340,
        "selector": "L340-L342",
        "symbol": "UniqueConstraint.contains_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "168b2d21-dd77-4243-9a73-d583bc00ae8b",
  "subject_name": "django/db/models/constraints::UniqueConstraint.contains_expressions",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def contains_expressions(self)"
}
```
