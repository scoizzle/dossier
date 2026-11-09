# Fact efa3db3d

Store id: 20b5fbaf-e41f-4f7e-b66a-089f1cee7e94

## Text

```text
def __init__(self, value, output_field=None)
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
- posted_at: `2026-11-09T23:44:49.5211520+00:00`

## Data

```json
{
  "end_line": 1166,
  "entity_kind": "method",
  "parent": "Value",
  "start_line": 1156,
  "symbol": "Value.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1156,"selector":"L1156-L1166","symbol":"Value.__init__"}`

## Items

```json
[
  {
    "text": "Arguments: * value: the value this expression represents. The value will be added into the sql parameter list and properly quoted.",
    "locator": {
      "line": 1157
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::Value.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1166,
    "entity_kind": "method",
    "parent": "Value",
    "start_line": 1156,
    "symbol": "Value.__init__"
  },
  "id": "20b5fbaf-e41f-4f7e-b66a-089f1cee7e94",
  "items": [
    {
      "locator": {
        "line": 1157
      },
      "text": "Arguments: * value: the value this expression represents. The value will be added into the sql parameter list and properly quoted."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5211520+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1156,
        "selector": "L1156-L1166",
        "symbol": "Value.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "cb8ca112-db4f-41e9-923e-7eaa1f21b44f",
  "subject_name": "django/db/models/expressions::Value.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, value, output_field=None)"
}
```
