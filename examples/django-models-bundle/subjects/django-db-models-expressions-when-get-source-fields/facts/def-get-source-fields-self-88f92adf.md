# Fact 88f92adf

Store id: 973c4cf2-6f2a-476e-aa8b-7bca54bee4e6

## Text

```text
def get_source_fields(self)
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
- posted_at: `2026-11-09T23:44:49.6154630+00:00`

## Data

```json
{
  "end_line": 1687,
  "entity_kind": "method",
  "parent": "When",
  "start_line": 1685,
  "symbol": "When.get_source_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1685,"selector":"L1685-L1687","symbol":"When.get_source_fields"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::When.get_source_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1687,
    "entity_kind": "method",
    "parent": "When",
    "start_line": 1685,
    "symbol": "When.get_source_fields"
  },
  "id": "973c4cf2-6f2a-476e-aa8b-7bca54bee4e6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6154630+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1685,
        "selector": "L1685-L1687",
        "symbol": "When.get_source_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "50b346d3-a002-49e6-bf54-52cca1563ec3",
  "subject_name": "django/db/models/expressions::When.get_source_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_fields(self)"
}
```
