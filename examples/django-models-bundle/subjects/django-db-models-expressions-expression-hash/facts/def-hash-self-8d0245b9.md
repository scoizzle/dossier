# Fact 8d0245b9

Store id: 960cb58e-e0f4-4cf9-b99a-16e318911969

## Text

```text
def __hash__(self)
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
- posted_at: `2026-11-09T23:44:49.4281340+00:00`

## Data

```json
{
  "end_line": 562,
  "entity_kind": "method",
  "parent": "Expression",
  "start_line": 561,
  "symbol": "Expression.__hash__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":561,"selector":"L561-L562","symbol":"Expression.__hash__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Expression.__hash__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 562,
    "entity_kind": "method",
    "parent": "Expression",
    "start_line": 561,
    "symbol": "Expression.__hash__"
  },
  "id": "960cb58e-e0f4-4cf9-b99a-16e318911969",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4281340+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 561,
        "selector": "L561-L562",
        "symbol": "Expression.__hash__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "ad4706c7-8b6d-49b5-b063-46f7d5413694",
  "subject_name": "django/db/models/expressions::Expression.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```
