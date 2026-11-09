# Fact 26684d00

Store id: bd64bca7-9915-4eef-b1ff-3faaeb84b898

## Text

```text
def asc(self)
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
- posted_at: `2026-11-09T23:44:49.6641000+00:00`

## Data

```json
{
  "end_line": 2014,
  "entity_kind": "method",
  "parent": "OrderBy",
  "start_line": 2013,
  "symbol": "OrderBy.asc"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2013,"selector":"L2013-L2014","symbol":"OrderBy.asc"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::OrderBy.asc](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2014,
    "entity_kind": "method",
    "parent": "OrderBy",
    "start_line": 2013,
    "symbol": "OrderBy.asc"
  },
  "id": "bd64bca7-9915-4eef-b1ff-3faaeb84b898",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6641000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2013,
        "selector": "L2013-L2014",
        "symbol": "OrderBy.asc"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "8832d30c-5e63-4848-9798-4b43556aa294",
  "subject_name": "django/db/models/expressions::OrderBy.asc",
  "tags": [
    "entity:method"
  ],
  "text": "def asc(self)"
}
```
