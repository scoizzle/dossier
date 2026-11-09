# Fact 0f4effd9

Store id: ceb439bb-f9ee-44e0-92bf-2830731306da

## Text

```text
def __init__(self, rel, reverse=False)
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
- posted_at: `2026-11-09T23:31:59.3108380+00:00`

## Data

```json
{
  "end_line": 1048,
  "entity_kind": "method",
  "parent": "ManyToManyDescriptor",
  "start_line": 1045,
  "symbol": "ManyToManyDescriptor.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1045,"selector":"L1045-L1048","symbol":"ManyToManyDescriptor.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ManyToManyDescriptor.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1048,
    "entity_kind": "method",
    "parent": "ManyToManyDescriptor",
    "start_line": 1045,
    "symbol": "ManyToManyDescriptor.__init__"
  },
  "id": "ceb439bb-f9ee-44e0-92bf-2830731306da",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.3108380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1045,
        "selector": "L1045-L1048",
        "symbol": "ManyToManyDescriptor.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "619f7339-a994-4c2f-9203-c286d9919876",
  "subject_name": "django/db/models/fields/related_descriptors::ManyToManyDescriptor.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, rel, reverse=False)"
}
```
