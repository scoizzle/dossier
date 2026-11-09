# Fact 8a62ed7f

Store id: 9532d350-b73e-4bad-852d-4a4872b75104

## Text

```text
def set_source_expressions(self, exprs)
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
- posted_at: `2026-11-09T23:44:49.6833040+00:00`

## Data

```json
{
  "end_line": 2159,
  "entity_kind": "method",
  "parent": "WindowFrame",
  "start_line": 2158,
  "symbol": "WindowFrame.set_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2158,"selector":"L2158-L2159","symbol":"WindowFrame.set_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::WindowFrame.set_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2159,
    "entity_kind": "method",
    "parent": "WindowFrame",
    "start_line": 2158,
    "symbol": "WindowFrame.set_source_expressions"
  },
  "id": "9532d350-b73e-4bad-852d-4a4872b75104",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6833040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2158,
        "selector": "L2158-L2159",
        "symbol": "WindowFrame.set_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "d807c8f8-fd3d-4bec-95a7-37ce1d5f1a7f",
  "subject_name": "django/db/models/expressions::WindowFrame.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```
