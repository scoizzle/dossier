# Fact e42b7c7f

Store id: d4d00acc-a044-4728-a069-eb9bf10de2ab

## Text

```text
def __eq__(self, other)
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
- posted_at: `2026-11-09T23:31:55.8027420+00:00`

## Data

```json
{
  "end_line": 559,
  "entity_kind": "method",
  "parent": "Expression",
  "start_line": 556,
  "symbol": "Expression.__eq__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":556,"selector":"L556-L559","symbol":"Expression.__eq__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Expression.__eq__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 559,
    "entity_kind": "method",
    "parent": "Expression",
    "start_line": 556,
    "symbol": "Expression.__eq__"
  },
  "id": "d4d00acc-a044-4728-a069-eb9bf10de2ab",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8027420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 556,
        "selector": "L556-L559",
        "symbol": "Expression.__eq__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "d72acaec-9034-45a9-b13e-0122c07ce744",
  "subject_name": "django/db/models/expressions::Expression.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```
