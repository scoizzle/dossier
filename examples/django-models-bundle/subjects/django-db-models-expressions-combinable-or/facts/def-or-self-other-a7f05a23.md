# Fact a7f05a23

Store id: f1d860a3-9a7c-485e-a0df-28c050010f70

## Text

```text
def __or__(self, other)
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
- posted_at: `2026-11-09T23:31:55.7395160+00:00`

## Data

```json
{
  "end_line": 128,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 123,
  "symbol": "Combinable.__or__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":123,"selector":"L123-L128","symbol":"Combinable.__or__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__or__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 128,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 123,
    "symbol": "Combinable.__or__"
  },
  "id": "f1d860a3-9a7c-485e-a0df-28c050010f70",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7395160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 123,
        "selector": "L123-L128",
        "symbol": "Combinable.__or__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "45c8c2ae-b275-493d-af71-96612e7c448e",
  "subject_name": "django/db/models/expressions::Combinable.__or__",
  "tags": [
    "entity:method"
  ],
  "text": "def __or__(self, other)"
}
```
