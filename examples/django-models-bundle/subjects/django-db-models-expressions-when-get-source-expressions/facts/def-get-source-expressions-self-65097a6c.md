# Fact 65097a6c

Store id: 5558fac3-ac23-4586-bd86-1af818b3ae43

## Text

```text
def get_source_expressions(self)
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
- posted_at: `2026-11-09T23:44:49.6119880+00:00`

## Data

```json
{
  "end_line": 1668,
  "entity_kind": "method",
  "parent": "When",
  "start_line": 1667,
  "symbol": "When.get_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1667,"selector":"L1667-L1668","symbol":"When.get_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::When.get_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1668,
    "entity_kind": "method",
    "parent": "When",
    "start_line": 1667,
    "symbol": "When.get_source_expressions"
  },
  "id": "5558fac3-ac23-4586-bd86-1af818b3ae43",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6119880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1667,
        "selector": "L1667-L1668",
        "symbol": "When.get_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "3e9a87c2-444f-4fe0-8cd6-f582bc651354",
  "subject_name": "django/db/models/expressions::When.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```
