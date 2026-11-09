# Fact 70cea43a

Store id: 583f9ed0-74eb-4548-bb0a-c395fe125180

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T23:31:54.1581370+00:00`

## Data

```json
{
  "end_line": 128,
  "entity_kind": "method",
  "parent": "BaseConstraint",
  "start_line": 117,
  "symbol": "BaseConstraint.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":117,"selector":"L117-L128","symbol":"BaseConstraint.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::BaseConstraint.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 128,
    "entity_kind": "method",
    "parent": "BaseConstraint",
    "start_line": 117,
    "symbol": "BaseConstraint.deconstruct"
  },
  "id": "583f9ed0-74eb-4548-bb0a-c395fe125180",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.1581370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 117,
        "selector": "L117-L128",
        "symbol": "BaseConstraint.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "22025ba8-adc8-430a-8895-8d9ce7cc2e0f",
  "subject_name": "django/db/models/constraints::BaseConstraint.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
