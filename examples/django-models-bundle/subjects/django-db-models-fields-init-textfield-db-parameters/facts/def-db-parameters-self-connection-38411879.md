# Fact 38411879

Store id: e6dddf36-0d31-4206-9395-ce36d1152524

## Text

```text
def db_parameters(self, connection)
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
- posted_at: `2026-11-09T23:31:56.7988950+00:00`

## Data

```json
{
  "end_line": 2563,
  "entity_kind": "method",
  "parent": "TextField",
  "start_line": 2560,
  "symbol": "TextField.db_parameters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2560,"selector":"L2560-L2563","symbol":"TextField.db_parameters"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TextField.db_parameters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2563,
    "entity_kind": "method",
    "parent": "TextField",
    "start_line": 2560,
    "symbol": "TextField.db_parameters"
  },
  "id": "e6dddf36-0d31-4206-9395-ce36d1152524",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7988950+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2560,
        "selector": "L2560-L2563",
        "symbol": "TextField.db_parameters"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "92f1a14b-6634-480c-84df-80dd7f328188",
  "subject_name": "django/db/models/fields/__init__::TextField.db_parameters",
  "tags": [
    "entity:method"
  ],
  "text": "def db_parameters(self, connection)"
}
```
