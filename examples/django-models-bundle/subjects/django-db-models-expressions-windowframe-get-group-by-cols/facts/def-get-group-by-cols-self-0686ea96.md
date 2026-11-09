# Fact 0686ea96

Store id: bb53e3de-8827-4324-905f-b2d8fdfd40ae

## Text

```text
def get_group_by_cols(self)
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
- posted_at: `2026-11-09T23:44:49.6888940+00:00`

## Data

```json
{
  "end_line": 2193,
  "entity_kind": "method",
  "parent": "WindowFrame",
  "start_line": 2192,
  "symbol": "WindowFrame.get_group_by_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2192,"selector":"L2192-L2193","symbol":"WindowFrame.get_group_by_cols"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::WindowFrame.get_group_by_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2193,
    "entity_kind": "method",
    "parent": "WindowFrame",
    "start_line": 2192,
    "symbol": "WindowFrame.get_group_by_cols"
  },
  "id": "bb53e3de-8827-4324-905f-b2d8fdfd40ae",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6888940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2192,
        "selector": "L2192-L2193",
        "symbol": "WindowFrame.get_group_by_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "aef5b208-e242-456e-ab26-73ee02f805de",
  "subject_name": "django/db/models/expressions::WindowFrame.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```
