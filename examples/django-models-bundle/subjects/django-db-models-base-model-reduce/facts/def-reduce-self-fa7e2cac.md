# Fact fa7e2cac

Store id: 3e16e8d3-2f5c-43d7-a2c3-082394bf790a

## Text

```text
def __reduce__(self)
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
- posted_at: `2026-11-09T23:31:53.7344000+00:00`

## Data

```json
{
  "end_line": 657,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 653,
  "symbol": "Model.__reduce__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":653,"selector":"L653-L657","symbol":"Model.__reduce__"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.__reduce__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 657,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 653,
    "symbol": "Model.__reduce__"
  },
  "id": "3e16e8d3-2f5c-43d7-a2c3-082394bf790a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7344000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 653,
        "selector": "L653-L657",
        "symbol": "Model.__reduce__"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "6ac72722-ef44-4941-a641-d4ad456bd6eb",
  "subject_name": "django/db/models/base::Model.__reduce__",
  "tags": [
    "entity:method"
  ],
  "text": "def __reduce__(self)"
}
```
