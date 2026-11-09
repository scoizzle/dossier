# Fact 4db6958d

Store id: fc75951f-e737-4963-82a2-0814215fbb3d

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
- posted_at: `2026-11-09T23:31:56.0301500+00:00`

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
  "id": "fc75951f-e737-4963-82a2-0814215fbb3d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.0301500+00:00"
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
  "subject_id": "b3ff496f-a3dd-4dd6-8c4a-121e3d786bf3",
  "subject_name": "django/db/models/expressions::WindowFrame.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
