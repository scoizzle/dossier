# Fact 3a9b1b78

Store id: 878365b8-6652-4abd-b080-07608e688743

## Text

```text
def contribute_to_class(self, cls, name, **kwargs)
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
- posted_at: `2026-11-09T23:31:56.5848610+00:00`

## Data

```json
{
  "end_line": 1574,
  "entity_kind": "method",
  "parent": "DateField",
  "start_line": 1558,
  "symbol": "DateField.contribute_to_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1558,"selector":"L1558-L1574","symbol":"DateField.contribute_to_class"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateField.contribute_to_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1574,
    "entity_kind": "method",
    "parent": "DateField",
    "start_line": 1558,
    "symbol": "DateField.contribute_to_class"
  },
  "id": "878365b8-6652-4abd-b080-07608e688743",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5848610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1558,
        "selector": "L1558-L1574",
        "symbol": "DateField.contribute_to_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "8adc06ba-31af-44a8-b8f1-963adbe6a922",
  "subject_name": "django/db/models/fields/__init__::DateField.contribute_to_class",
  "tags": [
    "entity:method"
  ],
  "text": "def contribute_to_class(self, cls, name, **kwargs)"
}
```
