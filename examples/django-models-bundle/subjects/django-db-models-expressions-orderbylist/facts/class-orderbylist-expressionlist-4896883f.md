# Fact 4896883f

Store id: 5515543f-ebb8-4713-a0b2-3208c40953a1

## Text

```text
class OrderByList(ExpressionList)
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
- posted_at: `2026-11-09T23:44:49.5906570+00:00`

## Data

```json
{
  "end_line": 1544,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 1516,
  "symbol": "OrderByList"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1516,"selector":"L1516-L1544","symbol":"OrderByList"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::OrderByList](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1544,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 1516,
    "symbol": "OrderByList"
  },
  "id": "5515543f-ebb8-4713-a0b2-3208c40953a1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5906570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1516,
        "selector": "L1516-L1544",
        "symbol": "OrderByList"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "31be472e-e850-4cf3-bef9-07ec39262fee",
  "subject_name": "django/db/models/expressions::OrderByList",
  "tags": [
    "entity:class"
  ],
  "text": "class OrderByList(ExpressionList)"
}
```
