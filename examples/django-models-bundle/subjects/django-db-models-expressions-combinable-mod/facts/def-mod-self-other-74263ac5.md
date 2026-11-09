# Fact 74263ac5

Store id: ccb9032f-a41a-480a-9412-5c7cc39fb255

## Text

```text
def __mod__(self, other)
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
- posted_at: `2026-11-09T23:44:49.2444040+00:00`

## Data

```json
{
  "end_line": 92,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 91,
  "symbol": "Combinable.__mod__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":91,"selector":"L91-L92","symbol":"Combinable.__mod__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__mod__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 92,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 91,
    "symbol": "Combinable.__mod__"
  },
  "id": "ccb9032f-a41a-480a-9412-5c7cc39fb255",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.2444040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 91,
        "selector": "L91-L92",
        "symbol": "Combinable.__mod__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "050eed04-24ed-4523-875c-046574a71985",
  "subject_name": "django/db/models/expressions::Combinable.__mod__",
  "tags": [
    "entity:method"
  ],
  "text": "def __mod__(self, other)"
}
```
