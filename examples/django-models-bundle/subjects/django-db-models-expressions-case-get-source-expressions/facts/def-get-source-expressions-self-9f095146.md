# Fact 9f095146

Store id: 3ec19150-2fbe-477e-85c2-440601df2335

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
- posted_at: `2026-11-09T22:39:41.7117890+00:00`

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
  "id": "3ec19150-2fbe-477e-85c2-440601df2335",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7117890+00:00"
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
  "subject_id": "8845fee5-4ce2-41f0-8beb-175bace6e00a",
  "subject_name": "django/db/models/expressions::Case.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```
