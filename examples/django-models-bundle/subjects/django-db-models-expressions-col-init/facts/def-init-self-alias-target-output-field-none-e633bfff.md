# Fact e633bfff

Store id: e58b5a25-a538-401a-a523-2a9eb2335559

## Text

```text
def __init__(self, alias, target, output_field=None)
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
- posted_at: `2026-11-09T23:31:55.8902690+00:00`

## Data

```json
{
  "end_line": 1359,
  "entity_kind": "method",
  "parent": "Col",
  "start_line": 1355,
  "symbol": "Col.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1355,"selector":"L1355-L1359","symbol":"Col.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Col.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1359,
    "entity_kind": "method",
    "parent": "Col",
    "start_line": 1355,
    "symbol": "Col.__init__"
  },
  "id": "e58b5a25-a538-401a-a523-2a9eb2335559",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8902690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1355,
        "selector": "L1355-L1359",
        "symbol": "Col.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "e7110d5e-f01b-4b45-9979-c027f3332d79",
  "subject_name": "django/db/models/expressions::Col.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, alias, target, output_field=None)"
}
```
