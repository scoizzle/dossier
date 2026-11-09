# Fact 03d3ad73

Store id: 8f363a6d-a0ad-448e-b666-b64762972c9a

## Text

```text
def __call__(self, *, manager)
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
- posted_at: `2026-11-09T23:31:59.3589170+00:00`

## Data

```json
{
  "end_line": 1139,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1134,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.__call__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1134,"selector":"L1134-L1139","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.__call__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.__call__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1139,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1134,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.__call__"
  },
  "id": "8f363a6d-a0ad-448e-b666-b64762972c9a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.3589170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1134,
        "selector": "L1134-L1139",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.__call__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "0589cd8d-705e-48e1-9945-6d397ef052b0",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.__call__",
  "tags": [
    "entity:method"
  ],
  "text": "def __call__(self, *, manager)"
}
```
