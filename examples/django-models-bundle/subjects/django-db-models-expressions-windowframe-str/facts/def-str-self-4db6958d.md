# Fact 4db6958d

Store id: 6c7cf76c-9a2b-4e16-b4f5-fb0162ebbb57

## Text

```text
def __str__(self)
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
- posted_at: `2026-11-09T23:44:49.6900130+00:00`

## Data

```json
{
  "end_line": 2218,
  "entity_kind": "method",
  "parent": "WindowFrame",
  "start_line": 2195,
  "symbol": "WindowFrame.__str__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2195,"selector":"L2195-L2218","symbol":"WindowFrame.__str__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::WindowFrame.__str__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2218,
    "entity_kind": "method",
    "parent": "WindowFrame",
    "start_line": 2195,
    "symbol": "WindowFrame.__str__"
  },
  "id": "6c7cf76c-9a2b-4e16-b4f5-fb0162ebbb57",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6900130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2195,
        "selector": "L2195-L2218",
        "symbol": "WindowFrame.__str__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "17f4f96d-4490-47d4-af16-d1f732e93689",
  "subject_name": "django/db/models/expressions::WindowFrame.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
