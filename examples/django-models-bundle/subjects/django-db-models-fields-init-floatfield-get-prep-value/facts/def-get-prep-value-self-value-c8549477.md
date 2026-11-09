# Fact c8549477

Store id: d3d26f0a-fd57-4521-8bbc-b7885685aba3

## Text

```text
def get_prep_value(self, value)
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
- posted_at: `2026-11-09T23:31:56.6862070+00:00`

## Data

```json
{
  "end_line": 2115,
  "entity_kind": "method",
  "parent": "FloatField",
  "start_line": 2106,
  "symbol": "FloatField.get_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2106,"selector":"L2106-L2115","symbol":"FloatField.get_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::FloatField.get_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2115,
    "entity_kind": "method",
    "parent": "FloatField",
    "start_line": 2106,
    "symbol": "FloatField.get_prep_value"
  },
  "id": "d3d26f0a-fd57-4521-8bbc-b7885685aba3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6862070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2106,
        "selector": "L2106-L2115",
        "symbol": "FloatField.get_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "5507533a-f762-405a-8bc6-6831ebc15fda",
  "subject_name": "django/db/models/fields/__init__::FloatField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
