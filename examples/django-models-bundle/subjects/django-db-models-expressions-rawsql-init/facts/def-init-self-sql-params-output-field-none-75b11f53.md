# Fact 75b11f53

Store id: aa5ec2a8-4ba8-4ac7-850c-bd813306510b

## Text

```text
def __init__(self, sql, params, output_field=None)
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
- posted_at: `2026-11-09T23:31:55.8721300+00:00`

## Data

```json
{
  "end_line": 1275,
  "entity_kind": "method",
  "parent": "RawSQL",
  "start_line": 1271,
  "symbol": "RawSQL.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1271,"selector":"L1271-L1275","symbol":"RawSQL.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::RawSQL.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1275,
    "entity_kind": "method",
    "parent": "RawSQL",
    "start_line": 1271,
    "symbol": "RawSQL.__init__"
  },
  "id": "aa5ec2a8-4ba8-4ac7-850c-bd813306510b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8721300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1271,
        "selector": "L1271-L1275",
        "symbol": "RawSQL.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "6cce09af-ca89-4b2e-9282-4f2a27afc269",
  "subject_name": "django/db/models/expressions::RawSQL.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, sql, params, output_field=None)"
}
```
