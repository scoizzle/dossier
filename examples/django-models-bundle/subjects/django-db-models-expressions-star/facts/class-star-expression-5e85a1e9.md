# Fact 5e85a1e9

Store id: a99b886b-03d6-49bd-890c-bc0ab6bac876

## Text

```text
class Star(Expression)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.6114630+00:00`

## Data

```json
{
  "end_line": 1308,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 1303,
  "symbol": "Star"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1303,"selector":"L1303-L1308","symbol":"Star"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Star](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1308,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 1303,
    "symbol": "Star"
  },
  "id": "a99b886b-03d6-49bd-890c-bc0ab6bac876",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6114630+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1303,
        "selector": "L1303-L1308",
        "symbol": "Star"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "965cdd4d-19ef-4949-be11-36ae26f6d72a",
  "subject_name": "django/db/models/expressions::Star",
  "tags": [
    "entity:class"
  ],
  "text": "class Star(Expression)"
}
```
