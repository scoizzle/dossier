# Fact 79d4cbf7

Store id: 2616e07a-0111-4a0a-b886-31c5b4c71dd3

## Text

```text
async def adelete(self, using=None, keep_parents=False)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `async`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:48.5380360+00:00`

## Data

```json
{
  "end_line": 1341,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1337,
  "symbol": "Model.adelete"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1337,"selector":"L1337-L1341","symbol":"Model.adelete"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.adelete](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1341,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1337,
    "symbol": "Model.adelete"
  },
  "id": "2616e07a-0111-4a0a-b886-31c5b4c71dd3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5380360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1337,
        "selector": "L1337-L1341",
        "symbol": "Model.adelete"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "b6ca2a84-6b5f-4aac-ae5c-20d9db8bec85",
  "subject_name": "django/db/models/base::Model.adelete",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def adelete(self, using=None, keep_parents=False)"
}
```
