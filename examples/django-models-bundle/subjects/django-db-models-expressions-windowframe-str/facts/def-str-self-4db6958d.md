# Fact 4db6958d

Store id: f9558a97-1d11-4b56-b0ab-fccd470ca0e5

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
- posted_at: `2026-11-09T22:39:41.7860310+00:00`

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
  "id": "f9558a97-1d11-4b56-b0ab-fccd470ca0e5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7860310+00:00"
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
  "subject_id": "7df0e4b1-6c12-46a7-b2c3-9197c160cff1",
  "subject_name": "django/db/models/expressions::WindowFrame.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
