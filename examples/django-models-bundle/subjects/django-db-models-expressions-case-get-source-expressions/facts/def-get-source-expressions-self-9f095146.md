# Fact 9f095146

Store id: c39aea4e-e033-4202-a813-015276930039

## Text

```text
def get_source_expressions(self)
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
- posted_at: `2026-11-09T23:44:49.6265380+00:00`

## Data

```json
{
  "end_line": 1751,
  "entity_kind": "method",
  "parent": "Case",
  "start_line": 1750,
  "symbol": "Case.get_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1750,"selector":"L1750-L1751","symbol":"Case.get_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Case.get_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1751,
    "entity_kind": "method",
    "parent": "Case",
    "start_line": 1750,
    "symbol": "Case.get_source_expressions"
  },
  "id": "c39aea4e-e033-4202-a813-015276930039",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6265380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1750,
        "selector": "L1750-L1751",
        "symbol": "Case.get_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "a0a72aec-33ab-4914-be9f-532bc6504d86",
  "subject_name": "django/db/models/expressions::Case.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```
