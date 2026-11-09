# Fact b0e025b6

Store id: 639f70fb-adc3-4b0d-98f0-7dee6e339886

## Text

```text
def replace_expressions(self, replacements)
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
- posted_at: `2026-11-09T23:32:05.0765980+00:00`

## Data

```json
{
  "end_line": 154,
  "entity_kind": "method",
  "parent": "Q",
  "start_line": 117,
  "symbol": "Q.replace_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":117,"selector":"L117-L154","symbol":"Q.replace_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q.replace_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 154,
    "entity_kind": "method",
    "parent": "Q",
    "start_line": 117,
    "symbol": "Q.replace_expressions"
  },
  "id": "639f70fb-adc3-4b0d-98f0-7dee6e339886",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.0765980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 117,
        "selector": "L117-L154",
        "symbol": "Q.replace_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "135918ad-2bcf-4cc6-9223-b780a0bb7b5e",
  "subject_name": "django/db/models/query_utils::Q.replace_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def replace_expressions(self, replacements)"
}
```
